/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="bass-step")]
public partial class BassStep {
    
    private string textField;
    
    private Step valueField;
    
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
    public Step Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}