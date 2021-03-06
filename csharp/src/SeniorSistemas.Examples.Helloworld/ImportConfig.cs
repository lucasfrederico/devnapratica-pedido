namespace SeniorSistemas.Examples.Helloworld
{
    
    /// This is a generated file. DO NOT EDIT ANY CODE HERE, YOUR CHANGES WILL BE LOST.
    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    			
    ///<summary>
    /// TBD
    ///</summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("sdl", "25.1.4")]
    public class ImportConfig
    {
        
        ///<summary>
        /// TBD
        ///</summary>
        public string Uri { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public Layoutdto Layout { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public bool? Async { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public long? BatchSize { get; set; }
        
        ///<summary>
        /// TBD
        ///</summary>
        public ErrorStrategy? ErrorStrategy { get; set; }
        
        /// <summary>
        /// Constructor for ImportConfig
        /// </summary>
        /// <param name="uri">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="layout">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="async">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="batchSize">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        /// <param name="errorStrategy">
        ///<summary>
        /// TBD
        ///</summary>
        /// </param>
        public ImportConfig(string uri, Layoutdto layout, bool? async, long? batchSize, ErrorStrategy? errorStrategy)
        {
            this.Uri = uri;
            this.Layout = layout;
            this.Async = async;
            this.BatchSize = batchSize;
            this.ErrorStrategy = errorStrategy;
        }
        
        public virtual void Validate()
        {
        	Validate(new ArrayList());
        }
        
        internal virtual void Validate(IList validated)
        {
            HelloWorldValidator.Validate(this, validated);
        }
    }
}
