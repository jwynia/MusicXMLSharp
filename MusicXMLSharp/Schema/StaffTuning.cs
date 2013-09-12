/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="staff-tuning")]
public partial class StaffTuning {
    
    private Step tuningstepField;
    
    private decimal tuningalterField;
    
    private bool tuningalterFieldSpecified;
    
    private string tuningoctaveField;
    
    private string lineField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tuning-step")]
    public Step tuningstep {
        get {
            return this.tuningstepField;
        }
        set {
            this.tuningstepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tuning-alter")]
    public decimal tuningalter {
        get {
            return this.tuningalterField;
        }
        set {
            this.tuningalterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tuningalterSpecified {
        get {
            return this.tuningalterFieldSpecified;
        }
        set {
            this.tuningalterFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tuning-octave", DataType="integer")]
    public string tuningoctave {
        get {
            return this.tuningoctaveField;
        }
        set {
            this.tuningoctaveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string line {
        get {
            return this.lineField;
        }
        set {
            this.lineField = value;
        }
    }
}