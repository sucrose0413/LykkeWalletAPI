﻿namespace LykkeApi2.Models.ApiKey
{
    public class CreateApiKeyRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Apiv2Only { get; set; }
    }
}
