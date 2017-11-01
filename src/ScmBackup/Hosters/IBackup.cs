﻿namespace ScmBackup.Hosters
{
    internal interface IBackup
    {
        /// <summary>
        /// backup everything from this repo which needs to be backed up
        /// </summary>
        bool MakeBackup(HosterRepository repo, Config config, string repoFolder);
    }
}
