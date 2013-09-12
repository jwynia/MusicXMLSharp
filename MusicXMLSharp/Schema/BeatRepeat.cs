/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="beat-repeat")]
public partial class BeatRepeat {
    
    private NoteTypeValue slashtypeField;
    
    private Empty[] slashdotField;
    
    private StartStop typeField;
    
    private string slashesField;
    
    private YesNo usedotsField;
    
    private bool usedotsFieldSpecified;
    
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
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string slashes {
        get {
            return this.slashesField;
        }
        set {
            this.slashesField = value;
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
}