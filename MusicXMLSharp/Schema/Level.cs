/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Level {
    
    private YesNo referenceField;
    
    private bool referenceFieldSpecified;
    
    private YesNo parenthesesField;
    
    private bool parenthesesFieldSpecified;
    
    private YesNo bracketField;
    
    private bool bracketFieldSpecified;
    
    private SymbolSize sizeField;
    
    private bool sizeFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool referenceSpecified {
        get {
            return this.referenceFieldSpecified;
        }
        set {
            this.referenceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo parentheses {
        get {
            return this.parenthesesField;
        }
        set {
            this.parenthesesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parenthesesSpecified {
        get {
            return this.parenthesesFieldSpecified;
        }
        set {
            this.parenthesesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo bracket {
        get {
            return this.bracketField;
        }
        set {
            this.bracketField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bracketSpecified {
        get {
            return this.bracketFieldSpecified;
        }
        set {
            this.bracketFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public SymbolSize size {
        get {
            return this.sizeField;
        }
        set {
            this.sizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeSpecified {
        get {
            return this.sizeFieldSpecified;
        }
        set {
            this.sizeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}