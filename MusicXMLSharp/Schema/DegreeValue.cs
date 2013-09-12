/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="degree-value")]
public partial class DegreeValue {
    
    private DegreeSymbolValue symbolField;
    
    private bool symbolFieldSpecified;
    
    private string textField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DegreeSymbolValue symbol {
        get {
            return this.symbolField;
        }
        set {
            this.symbolField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool symbolSpecified {
        get {
            return this.symbolFieldSpecified;
        }
        set {
            this.symbolFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType="positiveInteger")]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}