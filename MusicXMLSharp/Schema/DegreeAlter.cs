/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="degree-alter")]
public partial class DegreeAlter {
    
    private YesNo plusminusField;
    
    private bool plusminusFieldSpecified;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("plus-minus")]
    public YesNo plusminus {
        get {
            return this.plusminusField;
        }
        set {
            this.plusminusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool plusminusSpecified {
        get {
            return this.plusminusFieldSpecified;
        }
        set {
            this.plusminusFieldSpecified = value;
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