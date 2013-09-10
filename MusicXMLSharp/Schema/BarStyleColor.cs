/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="bar-style-color")]
public partial class BarStyleColor {
    
    private string colorField;
    
    private BarStyle valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public BarStyle Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}