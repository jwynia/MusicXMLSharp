/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Clef {
    
    private ClefSign signField;
    
    private string lineField;
    
    private string clefoctavechangeField;
    
    private string numberField;
    
    private YesNo additionalField;
    
    private bool additionalFieldSpecified;
    
    private SymbolSize sizeField;
    
    private bool sizeFieldSpecified;
    
    private YesNo afterbarlineField;
    
    private bool afterbarlineFieldSpecified;
    
    private YesNo printobjectField;
    
    private bool printobjectFieldSpecified;
    
    /// <remarks/>
    public ClefSign sign {
        get {
            return this.signField;
        }
        set {
            this.signField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string line {
        get {
            return this.lineField;
        }
        set {
            this.lineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("clef-octave-change", DataType="integer")]
    public string clefoctavechange {
        get {
            return this.clefoctavechangeField;
        }
        set {
            this.clefoctavechangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
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
    public YesNo additional {
        get {
            return this.additionalField;
        }
        set {
            this.additionalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool additionalSpecified {
        get {
            return this.additionalFieldSpecified;
        }
        set {
            this.additionalFieldSpecified = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute("after-barline")]
    public YesNo afterbarline {
        get {
            return this.afterbarlineField;
        }
        set {
            this.afterbarlineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool afterbarlineSpecified {
        get {
            return this.afterbarlineFieldSpecified;
        }
        set {
            this.afterbarlineFieldSpecified = value;
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
}