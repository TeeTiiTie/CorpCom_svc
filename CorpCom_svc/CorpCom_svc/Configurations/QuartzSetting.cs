﻿namespace CorpCom_svc.Configurations
{
    public class QuartzSetting
    {
        public bool EnableQuartz { get; set; }
        public Dictionary<string, string> Jobs { get; set; }
    }
}