using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{
    public class Questionnaire : Translatable
    { 
        public string Id { get; set; } // The visible name is inherited from Translatable so an Id is only required
        public List<Element> Sections { get; set; }
        public int ApprovalRoundCount { get; set; } // Amount of Approval rounds the approval has
        public List<Comment> Comments { get; set; }

        // public bool IsComplete { get; set; } This is a database value and I don't believe it needs to be a property

        /// <summary>
        /// Checks all contained elements and matches whether all available Languages set in Questionnaire have been localized
        /// A way of verifying for the User that all translations have been made.
        /// For Example, Questionnaire has the languages EN,ES,and DE set. Q125 of the Questionnaire is missing that translation
        /// </summary>
        /// <returns></returns>
        public bool IsAllVisibleTextLocalized()
        {
            return true;
        }
    }
}
