// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieConnection
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieConnection : ICobieReferencedObject
	{
		string @Name { get; }
		string @Description { get; }
		ICobieConnectionType @ConnectionType { get; }
		ICobieTypeOrComponent @ComponentA { get; }
		ICobieTypeOrComponent @ComponentB { get; }
		ICobieTypeOrComponent @RealizingComponent { get; }
		string @PortNameA { get; }
		string @PortNameB { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Connection", 25)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieConnection : CobieReferencedObject, IInstantiableEntity, ICobieConnection, IEquatable<@CobieConnection>
	{
		#region ICobieConnection explicit implementation
		string ICobieConnection.Name { get { return @Name; } }	
		string ICobieConnection.Description { get { return @Description; } }	
		ICobieConnectionType ICobieConnection.ConnectionType { get { return @ConnectionType; } }	
		ICobieTypeOrComponent ICobieConnection.ComponentA { get { return @ComponentA; } }	
		ICobieTypeOrComponent ICobieConnection.ComponentB { get { return @ComponentB; } }	
		ICobieTypeOrComponent ICobieConnection.RealizingComponent { get { return @RealizingComponent; } }	
		string ICobieConnection.PortNameA { get { return @PortNameA; } }	
		string ICobieConnection.PortNameB { get { return @PortNameB; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieConnection(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobieConnectionType _connectionType;
		private CobieTypeOrComponent _componentA;
		private CobieTypeOrComponent _componentB;
		private CobieTypeOrComponent _realizingComponent;
		private string _portNameA;
		private string _portNameB;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public CobieConnectionType @ConnectionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _connectionType;
				((IPersistEntity)this).Activate(false);
				return _connectionType;
			} 
			set
			{
				SetValue( v =>  _connectionType = v, _connectionType, value,  "ConnectionType", 8);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public CobieTypeOrComponent @ComponentA 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _componentA;
				((IPersistEntity)this).Activate(false);
				return _componentA;
			} 
			set
			{
				SetValue( v =>  _componentA = v, _componentA, value,  "ComponentA", 9);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public CobieTypeOrComponent @ComponentB 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _componentB;
				((IPersistEntity)this).Activate(false);
				return _componentB;
			} 
			set
			{
				SetValue( v =>  _componentB = v, _componentB, value,  "ComponentB", 10);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public CobieTypeOrComponent @RealizingComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _realizingComponent;
				((IPersistEntity)this).Activate(false);
				return _realizingComponent;
			} 
			set
			{
				SetValue( v =>  _realizingComponent = v, _realizingComponent, value,  "RealizingComponent", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public string @PortNameA 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _portNameA;
				((IPersistEntity)this).Activate(false);
				return _portNameA;
			} 
			set
			{
				SetValue( v =>  _portNameA = v, _portNameA, value,  "PortNameA", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public string @PortNameB 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _portNameB;
				((IPersistEntity)this).Activate(false);
				return _portNameB;
			} 
			set
			{
				SetValue( v =>  _portNameB = v, _portNameB, value,  "PortNameB", 13);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_connectionType = (CobieConnectionType)(value.EntityVal);
					return;
				case 8: 
					_componentA = (CobieTypeOrComponent)(value.EntityVal);
					return;
				case 9: 
					_componentB = (CobieTypeOrComponent)(value.EntityVal);
					return;
				case 10: 
					_realizingComponent = (CobieTypeOrComponent)(value.EntityVal);
					return;
				case 11: 
					_portNameA = value.StringVal;
					return;
				case 12: 
					_portNameB = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieConnection other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieConnection
            var root = (@CobieConnection)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieConnection left, @CobieConnection right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieConnection left, @CobieConnection right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}