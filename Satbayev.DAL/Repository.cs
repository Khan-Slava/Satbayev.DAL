using LiteDB;
namespace Satbayev.DAL
{
    public class Repository
    {
        public bool createQuestion(QuestionTemplate question) 
        {
            
            try
            {
                using (var db = new LiteDatabase(""))
                {
                
                    var col = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    col.Insert(question);
                    return true;

                } 

            }
            catch (Exception ex) {
                return false;
            }

        }
        

        public string GetAllQuestions() 
        {

            return null;
        }
    }

}