/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Offset {
    
    private YesNo soundField;
    
    private bool soundFieldSpecified;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public YesNo sound {
        get {
            return this.soundField;
        }
        set {
            this.soundField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool soundSpecified {
        get {
            return this.soundFieldSpecified;
        }
        set {
            this.soundFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}