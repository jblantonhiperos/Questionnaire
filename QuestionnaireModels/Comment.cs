using System;
using QuestionnaireModels.InputTypes;


namespace QuestionnaireModels
{
    public class Comment : Textbox //Not sure about this
    {
        public User Commenter { get; set; }
        public string EnteredText { get; set; } // Should this be translatable
        public DateTime ModifiedDate { get; set; }
        public DateTime CreateDate { get; set; }
        
        public Comment(User commenter, string comment)
        {
            Commenter = commenter;
            EnteredText = comment;
        }
        

    }
}
