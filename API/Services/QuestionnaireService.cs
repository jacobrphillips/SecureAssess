using System.Collections.Generic;
using API.Entities;

public class QuestionnaireService
{
    public List<Questionnaire> CreateQuestionnaires()
    {
        var questionnaires = new List<Questionnaire>
        {
            new Questionnaire
            {
                Title = "Cyber Essentials",
                Questions = new List<Question>
                {
                    new Question
                    {
                        Title = "Firewall Configuration",
                        Prompt = "Is the firewall configured correctly?",
                        AdditionalInfo = "Ensure all ports are closed except for necessary services.",
                        AssessorScore = new List<AnswerOption>
                        {
                            new AnswerOption { Text = "Compliant", Type = AnswerOptionType.Compliant },
                            new AnswerOption { Text = "Major Non-Compliance", Type = AnswerOptionType.MajorNonCompliance },
                            new AnswerOption { Text = "Automatic Failure", Type = AnswerOptionType.AutomaticFailure },
                            new AnswerOption { Text = "More Information Required", Type = AnswerOptionType.MoreInformationRequired }
                        }
                    },
                    new Question
                    {
                        Title = "Password Policy",
                        Prompt = "Are all users using strong passwords?",
                        AdditionalInfo = "Passwords should be at least 8 characters long and include a mix of letters, numbers, and symbols.",
                        AssessorScore = new List<AnswerOption>
                        {
                            new AnswerOption { Text = "Compliant", Type = AnswerOptionType.Compliant },
                            new AnswerOption { Text = "Major Non-Compliance", Type = AnswerOptionType.MajorNonCompliance },
                            new AnswerOption { Text = "More Information Required", Type = AnswerOptionType.MoreInformationRequired }
                        }
                    }
                }
            }
        };

        return questionnaires;
    }
}
