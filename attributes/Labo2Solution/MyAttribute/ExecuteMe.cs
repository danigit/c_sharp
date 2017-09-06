﻿using System;
namespace MyAttribute{
  [AttributeUsage( AttributeTargets.Method, AllowMultiple = true )]
  public class ExecuteMeAttribute: Attribute{
    public object[] param;
    public int Number { get; set; }
    public ExecuteMeAttribute( params object[] param ){
      this.param = param;
    }
  }
}