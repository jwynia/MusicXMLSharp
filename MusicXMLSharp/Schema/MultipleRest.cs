/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="multiple-rest")]
public partial class MultipleRest {
    
    private YesNo usesymbolsField;
    
    private bool usesymbolsFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("use-symbols")]
    public YesNo usesymbols {
        get {
            return this.usesymbolsField;
        }
        set {
            this.usesymbolsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool usesymbolsSpecified {
        get {
            return this.usesymbolsFieldSpecified;
        }
        set {
            this.usesymbolsFieldSpecified = value;
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