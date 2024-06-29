﻿namespace MetaService.Shared
{
    using System;
    using UniGame.Core.Runtime.SerializableType;

    [Serializable]
    public class SimpleResultMetaCallContract<TInput> : SimpleMetaCallContract<TInput, string>
    {
    }
    
    [Serializable]
    public class SimpleMetaCallContract<TOutput> : SimpleMetaCallContract<string, TOutput>
    {
    }
    
    [Serializable]
    public class SimpleMetaCallContract<TInput, TOuput> : RemoteCallContract<TInput, TOuput>
    {
        public string method = string.Empty;
        public SType input;
        public SType output;
        
        public SimpleMetaCallContract(string method)
            : this()
        {
            this.method = method;
        }
        
        public SimpleMetaCallContract()
        {
            input = typeof(TInput);
            output = typeof(TOuput);
        }
    }
}