using System;
using System.Drawing;
using System.IO;
using System.Linq;
using Quiz.Service.WcfService.Model;
using Quiz.Service.model.DatabaseEntity;
using QuizMaker.WcfService.Model;

namespace Quiz.Service.WcfService
{
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

        public Test GetTest()
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
                                         Name = t.name,
                                         Questions = questions
                                                            .Where(q => q.testId == t.id)
                                                            .Select(q => new Question
                                                                             {
                                                                                 Id = q.id,
                                                                                 QuestionText = q.question,
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
                    .ToList()[1];
            }
            return test;
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
