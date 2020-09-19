﻿using Volo.Abp.Data;

namespace SharpAbp.Abp.FileStoringManagement
{
    public class FileStoringManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = AbpCommonDbProperties.DbTablePrefix;

        public static string DbSchema { get; set; } = AbpCommonDbProperties.DbSchema;

        public const string ConnectionStringName = "AbpFileStoringManagement";
    }
}
