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
    /// Readonly interface for CobieZone
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieZone : ICobieAsset
	{
		IEnumerable<ICobieSpace> @Spaces { get; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Zone", 19)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieZone : CobieAsset, IInstantiableEntity, ICobieZone, IEquatable<@CobieZone>
	{
		#region ICobieZone explicit implementation
		IEnumerable<ICobieSpace> ICobieZone.Spaces { get { return @Spaces; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieZone(IModel model) : base(model) 		{ 
			Model = model; 
			_spaces = new OptionalItemSet<CobieSpace>( this, 0 );
		}

		#region Explicit attribute fields
		private OptionalItemSet<CobieSpace> _spaces;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 15)]
		public OptionalItemSet<CobieSpace> @Spaces 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _spaces;
				((IPersistEntity)this).Activate(false);
				return _spaces;
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
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 12: 
					if (_spaces == null) _spaces = new OptionalItemSet<CobieSpace>( this );
					_spaces.InternalAdd((CobieSpace)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieZone other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieZone
            var root = (@CobieZone)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieZone left, @CobieZone right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieZone left, @CobieZone right)
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