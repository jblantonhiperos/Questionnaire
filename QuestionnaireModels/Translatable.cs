using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireModels
{

    /// <summary>
    /// This is for customer translations only. Inputs and other non-customizable controls will have standard translations provided out of the box
    /// Should be the base inherited class for any object that may have visible text
    /// </summary>
    public class Translatable
    {
        /// <summary>
        /// Stores all of the translated text for the given object
        /// </summary>
        public Dictionary<LanguageEnum, string> VisibleTextTranslations { get; set; } 

        /// <summary>
        /// Takes a Json string (stored this way in the DB) and converts it into a VisibleTextTranslations
        /// </summary>
        /// <param name="translationJson">Ex. Stored in DB as JSON and  { 'language' : 'en', 'text' : 'Name' }</param>
        public void InitializeVisibleTextTranslations(string translationJson)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="language"></param>
        /// <param name="text"></param>
        public void UpdateTranslatedText(LanguageEnum language, string text)
        {
            if (VisibleTextTranslations.ContainsKey(language))
            {
                VisibleTextTranslations[language] = text;
            }
            else
            {
                VisibleTextTranslations.Add(language, text);
            }
            
        }

        /// <summary>
        /// Gets whatever languages have been translated already for the current object
        /// </summary>
        /// <returns>List of languages the current translatable object</returns>
        public List<string> GetLocalizedLanguages()
        {
            return new List<string>();

            //return VisibleTextTranslations.Keys
        }

        public string GetTranslatedText(string languageCode)
        {

            return "";
        }
    }
}
