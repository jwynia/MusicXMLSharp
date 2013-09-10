/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Grouping {
    
    private Feature[] featureField;
    
    private StartStopSingle typeField;
    
    private string numberField;
    
    private string memberofField;
    
    public Grouping() {
        this.numberField = "1";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("feature")]
    public Feature[] feature {
        get {
            return this.featureField;
        }
        set {
            this.featureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StartStopSingle type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    [System.ComponentModel.DefaultValueAttribute("1")]
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("member-of", DataType="token")]
    public string memberof {
        get {
            return this.memberofField;
        }
        set {
            this.memberofField = value;
        }
    }
}