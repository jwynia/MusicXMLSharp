/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Slash {
    
    private NoteTypeValue slashtypeField;
    
    private Empty[] slashdotField;
    
    private StartStop typeField;
    
    private YesNo usedotsField;
    
    private bool usedotsFieldSpecified;
    
    private YesNo usestemsField;
    
    private bool usestemsFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("slash-type")]
    public NoteTypeValue slashtype {
        get {
            return this.slashtypeField;
        }
        set {
            this.slashtypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("slash-dot")]
    public Empty[] slashdot {
        get {
            return this.slashdotField;
        }
        set {
            this.slashdotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StartStop type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("use-dots")]
    public YesNo usedots {
        get {
            return this.usedotsField;
        }
        set {
            this.usedotsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool usedotsSpecified {
        get {
            return this.usedotsFieldSpecified;
        }
        set {
            this.usedotsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("use-stems")]
    public YesNo usestems {
        get {
            return this.usestemsField;
        }
        set {
            this.usestemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool usestemsSpecified {
        get {
            return this.usestemsFieldSpecified;
        }
        set {
            this.usestemsFieldSpecified = value;
        }
    }
}