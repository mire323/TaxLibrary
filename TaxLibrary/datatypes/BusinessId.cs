using System;
using System.Collections.Generic;
using System.Text;
using TaxLibrary.data.exceptions;

namespace TaxLibrary.datatypes
{
    public class BusinessId : IComparable<BusinessId>
    {
        //private static final EcmLogger logger = EcmServiceLocator.getLogger(BusinessId.class);
        private const string SEPARATOR = "#";

        public enum IdType
        {
            ID,
            MASTER_ID
        }

        private EntityType entityType;
        private IdType idType;
        private TaxId entityId;
        private string value;

        private BusinessId(EntityType entityType, IdType idType, TaxId entityId)
        {
            this.entityType = entityType;
            this.idType = idType;
            this.entityId = entityId;
            value = idType + SEPARATOR + entityType.GetValue() + SEPARATOR + entityId.GetValue();
        }

        public BusinessId(EntityType entityType, Id entityId) : this(entityType, IdType.ID, entityId)
        {
        }

        public BusinessId(EntityType entityType, MasterId entityMasterId) : this(entityType, IdType.MASTER_ID, entityMasterId)
        {
        }

        private DataInstantiationException CreateException(string message)
        {
            //logger.error("DataInstantiationException " + message);
            return new DataInstantiationException(message);
        }
        /**
         * Kreira objekat tako što parsira prosledjen String.<br>
         * Očekuje se da prosledjeni String bude oblika "idType#entityType#idValue" (gde je znakom # označen sistemski separator među ovim podacima). Unutar vrednosti idType i entityType
         * se ne može naći znak separator, ali je sasvim moguće da se unutar idValue nalazi jedan ili više takvih znakova. Zato se parsiranje ne vrši preko String.split, nego "manuelno".<br>
         * @param value String oblika "idType#entityType#idValue"
         * @throws DataInstantiationException 
         */
        public BusinessId(String value)
        {
            this.value = value;
            string handyString = value;
            int index = handyString.IndexOf(SEPARATOR);
            if (index < 1)
            {
                throw CreateException("BusinessId(" + value + "). No separator");
            }
            idType = (IdType)Enum.Parse(typeof(IdType), handyString.Substring(0, index));
            if (idType == null)
            {
                throw CreateException("BusinessId(" + value + "). Wrong IdType");
            }

            handyString = handyString.Substring(index + 1);
            index = handyString.IndexOf(SEPARATOR);
            if (index < 1)
            {
                throw CreateException("BusinessId(" + value + "). No second separator");
            }
            entityType = new EntityType(handyString.Substring(0, index));

            entityId = new TaxId(handyString.Substring(index + 1));
        }

        /**
         * Kreira objekat tako što parsira prosledjen String.<br>
         * Očekuje se da prosledjeni String bude oblika "idType#entityType#idValue" (gde je znakom # označen sistemski separator među ovim podacima). Unutar vrednosti idType i entityType
         * se ne može naći znak separator, ali je sasvim moguće da se unutar idValue nalazi jedan ili više takvih znakova. Zato se parsiranje ne vrši preko String.split, nego "manuelno".<br>
         * @param value String oblika "idType#entityType#idValue"
         * @throws DataInstantiationException 
         */
        public static BusinessId Of(String value)
        {
            return new BusinessId(value);
        }

        public static BusinessId Of(EntityType entityType, Id entityId)
        {
            return new BusinessId(entityType, entityId);
        }

        public static BusinessId Of(EntityType entityType, MasterId entityId)
        {
            return new BusinessId(entityType, entityId);
        }

        public EntityType GetEntityType()
        {
            return entityType;
        }

        public IdType GetIdType()
        {
            return idType;
        }

        public TaxId GetEntityId()
        {
            return entityId;
        }

        public String GetValue()
        {
            return value;
        }

        public override int GetHashCode()
        {
            return GetValue().GetHashCode();
        }

        public override bool Equals(Object other)
        {
            if (other.GetType().IsInstanceOfType(typeof(BusinessId)))
            {
                return GetValue().Equals(((BusinessId)other).GetValue());
            }
            return false;
        }

        public override string ToString()
        {
            return value;
        }

        public int CompareTo(BusinessId other)
        {
            return GetValue().CompareTo(other.GetValue());
        }
    }
}