﻿namespace ScmBackup.Hosters
{
    /// <summary>
    /// validator for GitHub repositories
    /// </summary>
    internal class GithubConfigSourceValidator : IConfigSourceValidator
    {
        public ValidationResult Validate(ConfigSource config)
        {
            var result = new ValidationResult();

            if (config.Hoster != "github")
            {
                result.AddMessage(ErrorLevel.Error, string.Format(Resource.GetString("GithubWrongHoster"), config.Hoster));
            }

            if (config.Type != "user" && config.Type != "org")
            {
                result.AddMessage(ErrorLevel.Error, string.Format(Resource.GetString("GithubWrongType"), config.Type));
            }

            if (config.Name == "")
            {
                result.AddMessage(ErrorLevel.Error, Resource.GetString("GithubNameEmpty"));
            }

            return result;
        }
    }
}
