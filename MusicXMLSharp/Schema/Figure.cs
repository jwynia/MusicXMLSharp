/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Figure {
    
    private StyleText prefixField;
    
    private StyleText figurenumberField;
    
    private StyleText suffixField;
    
    private Extend extendField;
    
    /// <remarks/>
    public StyleText prefix {
        get {
            return this.prefixField;
        }
        set {
            this.prefixField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Figure-number")]
    public StyleText figurenumber {
        get {
            return this.figurenumberField;
        }
        set {
            this.figurenumberField = value;
        }
    }
    
    /// <remarks/>
    public StyleText suffix {
        get {
            return this.suffixField;
        }
        set {
            this.suffixField = value;
        }
    }
    
    /// <remarks/>
    public Extend extend {
        get {
            return this.extendField;
        }
        set {
            this.extendField = value;
        }
    }
}