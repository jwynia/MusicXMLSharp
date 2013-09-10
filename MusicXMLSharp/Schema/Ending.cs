/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Ending {
    
    private string numberField;
    
    private StartStopDiscontinue typeField;
    
    private YesNo printobjectField;
    
    private bool printobjectFieldSpecified;
    
    private decimal endlengthField;
    
    private bool endlengthFieldSpecified;
    
    private decimal textxField;
    
    private bool textxFieldSpecified;
    
    private decimal textyField;
    
    private bool textyFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StartStopDiscontinue type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
    public YesNo printobject {
        get {
            return this.printobjectField;
        }
        set {
            this.printobjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printobjectSpecified {
        get {
            return this.printobjectFieldSpecified;
        }
        set {
            this.printobjectFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("end-length")]
    public decimal endlength {
        get {
            return this.endlengthField;
        }
        set {
            this.endlengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endlengthSpecified {
        get {
            return this.endlengthFieldSpecified;
        }
        set {
            this.endlengthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("text-x")]
    public decimal textx {
        get {
            return this.textxField;
        }
        set {
            this.textxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool textxSpecified {
        get {
            return this.textxFieldSpecified;
        }
        set {
            this.textxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("text-y")]
    public decimal texty {
        get {
            return this.textyField;
        }
        set {
            this.textyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool textySpecified {
        get {
            return this.textyFieldSpecified;
        }
        set {
            this.textyFieldSpecified = value;
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