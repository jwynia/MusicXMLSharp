/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="staff-details")]
public partial class StaffDetails {
    
    private StaffType _staffTypeField;
    
    private bool stafftypeFieldSpecified;
    
    private string stafflinesField;
    
    private StaffTuning[] _staffTuningField;
    
    private string capoField;
    
    private decimal staffsizeField;
    
    private bool staffsizeFieldSpecified;
    
    private string numberField;
    
    private ShowFrets _showFretsField;
    
    private bool showfretsFieldSpecified;
    
    private YesNo printobjectField;
    
    private bool printobjectFieldSpecified;
    
    private YesNo printspacingField;
    
    private bool printspacingFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("staff-type")]
    public StaffType StaffType {
        get {
            return this._staffTypeField;
        }
        set {
            this._staffTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stafftypeSpecified {
        get {
            return this.stafftypeFieldSpecified;
        }
        set {
            this.stafftypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("staff-lines", DataType="nonNegativeInteger")]
    public string stafflines {
        get {
            return this.stafflinesField;
        }
        set {
            this.stafflinesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("staff-tuning")]
    public StaffTuning[] StaffTuning {
        get {
            return this._staffTuningField;
        }
        set {
            this._staffTuningField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
    public string capo {
        get {
            return this.capoField;
        }
        set {
            this.capoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("staff-size")]
    public decimal staffsize {
        get {
            return this.staffsizeField;
        }
        set {
            this.staffsizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool staffsizeSpecified {
        get {
            return this.staffsizeFieldSpecified;
        }
        set {
            this.staffsizeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
    public string number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("show-frets")]
    public ShowFrets ShowFrets {
        get {
            return this._showFretsField;
        }
        set {
            this._showFretsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool showfretsSpecified {
        get {
            return this.showfretsFieldSpecified;
        }
        set {
            this.showfretsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
    public YesNo printobject {
        get {
            return this.printobjectField;
        }
        set {
            this.printobjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printobjectSpecified {
        get {
            return this.printobjectFieldSpecified;
        }
        set {
            this.printobjectFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-spacing")]
    public YesNo printspacing {
        get {
            return this.printspacingField;
        }
        set {
            this.printspacingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printspacingSpecified {
        get {
            return this.printspacingFieldSpecified;
        }
        set {
            this.printspacingFieldSpecified = value;
        }
    }
}