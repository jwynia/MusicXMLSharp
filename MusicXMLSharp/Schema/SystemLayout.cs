/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="system-layout")]
public partial class SystemLayout {
    
    private SystemMargins _systemMarginsField;
    
    private decimal systemdistanceField;
    
    private bool systemdistanceFieldSpecified;
    
    private decimal topsystemdistanceField;
    
    private bool topsystemdistanceFieldSpecified;
    
    private SystemDividers _systemDividersField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("system-margins")]
    public SystemMargins SystemMargins {
        get {
            return this._systemMarginsField;
        }
        set {
            this._systemMarginsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("system-distance")]
    public decimal systemdistance {
        get {
            return this.systemdistanceField;
        }
        set {
            this.systemdistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemdistanceSpecified {
        get {
            return this.systemdistanceFieldSpecified;
        }
        set {
            this.systemdistanceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("top-system-distance")]
    public decimal topsystemdistance {
        get {
            return this.topsystemdistanceField;
        }
        set {
            this.topsystemdistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool topsystemdistanceSpecified {
        get {
            return this.topsystemdistanceFieldSpecified;
        }
        set {
            this.topsystemdistanceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("system-dividers")]
    public SystemDividers SystemDividers {
        get {
            return this._systemDividersField;
        }
        set {
            this._systemDividersField = value;
        }
    }
}