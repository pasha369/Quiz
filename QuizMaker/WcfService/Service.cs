using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.Models.DatabaseEntity;
using QuizMaker.WcfService.Model;

namespace QuizMaker.WcfService
{
    class Service : IAuth, ITestOperation, IFileTransfer
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
                                                                                     VariantText = v.variant
                                                                                 })
                                                                                 .ToList()
                                                                             })
                                                            .ToList()
                                     })
                    .FirstOrDefault();
            }
            return test;
        }

        public void UploadFile(TransImage request)
        {
            string filePath = Path.GetFullPath(request.Filename);

            File.WriteAllBytes(filePath, request.data);
            
        }
    }

}
