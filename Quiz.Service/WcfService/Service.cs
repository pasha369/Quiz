using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Quiz.Service.WcfService.Abstract;
using Quiz.Service.WcfService.Model;
using Quiz.Service.model.DatabaseEntity;

namespace Quiz.Service.WcfService
{
    /// <summary>
    /// WCF service for implement 
    /// IAuth, ITestOperation, IFileTransfer operation
    /// </summary>
    public class Service : IAuth, ITestOperation, IFileTransfer
    {
        public bool SignIn(string login, string password)
        {
            Users user;
            using (var context = new QuizDBEntities())
            {
                user = context.Users
                    .FirstOrDefault(c => c.user_login == login && c.user_pass == password);
            }
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public void SignUp(string name, string last_name, string login, string password)
        {
            throw new NotImplementedException();
        }

        public Test GetTest(int testId)
        {
            var test = new Test();
            using (var context = new QuizDBEntities())
            {
                var tests = context.Tests.ToArray();
                var questions = context.Questions.ToArray();
                var variants = context.Variants.ToArray();

                test = tests
                    .Select(t => new Test
                                     {
                                         Id = t.id,
                                         Name = t.name,
                                         Questions = questions
                                                            .Where(q => q.testId == t.id)
                                                            .Select(q => new Question
                                                                             {
                                                                                 Id = q.id,
                                                                                 QuestionText = q.question,
                                                                                 Type = q.question_type,
                                                                                 Variants = variants
                                                                                 .Where(v => v.questionId == q.id)
                                                                                 .Select(v => new Variant
                                                                                 {
                                                                                     Id = v.id,
                                                                                     VariantText = v.variant,
                                                                                     ImageUri = v.imgPath,
                                                                                     Type = v.variant_type
                                                                                 })
                                                                                 .ToList()
                                                                             })
                                                            .ToList()
                                     })
                    .FirstOrDefault(t => t.Id == testId);
            }
            return test;
        }

        public List<Answer> GetAnswers(int questionId)
        {
            var lstAnswers = new List<Answer>();
            using (var context = new QuizDBEntities())
            {
                lstAnswers = context.Answers
                    .Where(a => a.questionId == questionId)
                    .Select(a => new Answer()
                                     {
                                         id = a.id,
                                         variantId = a.variantId
                                     })
                    .ToList();
            }
            return lstAnswers;
        }

        public List<Test> GetPassedTests(int UserId)
        {
            var test = new List<Test>();
            using (var context = new QuizDBEntities())
            {
                var questions = context.Questions.ToArray();
                var variants = context.Variants.ToArray();

                var passedTestIdx = context.PassedTest.ToList()
                    .Where(t => t.userId == UserId)
                    .Select(t => t.testId).ToList();

                test = passedTestIdx
                    .Select(t => t != null ? GetTest(t.Value) : null)
                    .ToList();
            }
            return test;
        }

        public List<Test> GetAvailableTests(int userId)
        {
            List<Test> test;
            using (var context = new QuizDBEntities())
            {
                var passedTestIdx = context.PassedTest.ToList()
                    .Where(t => t.userId == userId)
                    .Select(t => t.testId).ToList();

                test = context.Tests.ToArray()
                    .Where(t => t != null && !passedTestIdx.Contains(t.id))
                    .Select(t => GetTest(t.id))
                    .ToList();
            }

            return test;
        }

        public void PassTest(int userId, int testId, double score)
        {
            using (var context = new QuizDBEntities())
            {
                var passedTest = new PassedTest();
                if(context.PassedTest.Count() > 0)
                {
                    passedTest.id = context.PassedTest.ToList().Select(t => t.id).Max() + 1;
                }
                else
                {
                    passedTest.id = 0;                    
                }
                passedTest.testId = testId;
                passedTest.userId = userId;
                passedTest.score = (int) score;

                
                try
                {
                    context.PassedTest.Add(passedTest);
                context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e); // or log to file, etc.
                    throw; // re-throw the exception if you want it to continue up the stack
                }
            }

        }

        public string UploadFile(byte[] data, string filename)
        {
            using (var ms = new MemoryStream(data))
            {
                try
                {
                    Image img = Image.FromStream(ms);
                    string dir_path =
                        Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                    var path = String.Format("{0}\\Images\\{1}",
                                             dir_path, filename);
                    img.Save(path);

                    return path;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                return "";
            }

        }

        public TransferedImage DownloadImage(string url)
        {
            TransferedImage imgOut = new TransferedImage();
            byte[] imgData;

            using (var ms = new MemoryStream())
            {
                Image img = Image.FromFile(url);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                imgData = ms.ToArray();
            }
            imgOut.data = imgData;
            imgOut.Filename = url.Split(@"\".ToArray()).Last();
            return imgOut;
        }
    }

}
