/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="degree-type")]
public partial class DegreeType {
    
    private string textField;
    
    private DegreeTypeValue valueField;
    
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
    [System.Xml.Serialization.XmlTextAttribute()]
    public DegreeTypeValue Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}