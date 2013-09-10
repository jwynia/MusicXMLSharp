/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("score-partwise", Namespace="", IsNullable=false)]
public partial class ScorePartwise {
    
    private Work workField;
    
    private string movementnumberField;
    
    private string movementtitleField;
    
    private identification identificationField;
    
    private defaults defaultsField;
    
    private credit[] creditField;
    
    private partlist partlistField;
    
    private scorepartwisePart[] partField;
    
    private string versionField;
    
    public ScorePartwise() {
        this.versionField = "1.0";
    }
    
    /// <remarks/>
    public Work work {
        get {
            return this.workField;
        }
        set {
            this.workField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("movement-number")]
    public string movementnumber {
        get {
            return this.movementnumberField;
        }
        set {
            this.movementnumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("movement-title")]
    public string movementtitle {
        get {
            return this.movementtitleField;
        }
        set {
            this.movementtitleField = value;
        }
    }
    
    /// <remarks/>
    public identification identification {
        get {
            return this.identificationField;
        }
        set {
            this.identificationField = value;
        }
    }
    
    /// <remarks/>
    public defaults defaults {
        get {
            return this.defaultsField;
        }
        set {
            this.defaultsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("credit")]
    public credit[] credit {
        get {
            return this.creditField;
        }
        set {
            this.creditField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("part-list")]
    public partlist partlist {
        get {
            return this.partlistField;
        }
        set {
            this.partlistField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("part")]
    public scorepartwisePart[] part {
        get {
            return this.partField;
        }
        set {
            this.partField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    [System.ComponentModel.DefaultValueAttribute("1.0")]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
}