/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Repeat {
    
    private BackwardForward directionField;
    
    private string timesField;
    
    private Winged wingedField;
    
    private bool wingedFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BackwardForward direction {
        get {
            return this.directionField;
        }
        set {
            this.directionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public string times {
        get {
            return this.timesField;
        }
        set {
            this.timesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public Winged winged {
        get {
            return this.wingedField;
        }
        set {
            this.wingedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool wingedSpecified {
        get {
            return this.wingedFieldSpecified;
        }
        set {
            this.wingedFieldSpecified = value;
        }
    }
}