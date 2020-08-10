﻿using System.Collections.Generic;

namespace SharpAbp.Abp.CSRedisCore
{
    public class CSRedisClientConfiguration
    {
        /// <summary>Name of configuration
        /// </summary>
        public string Name { get; set; }

        /// <summary>Mode
        /// </summary>
        public RedisMode Mode { get; set; }

        /// <summary>Connection string
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>Sentinel address
        /// </summary>
        public List<string> Sentinels { get; set; }

        /// <summary>ReadOnly
        /// </summary>
        public bool ReadOnly { get; set; }


        public CSRedisClientConfiguration()
        {
            Sentinels = new List<string>();
        }
    }
}
