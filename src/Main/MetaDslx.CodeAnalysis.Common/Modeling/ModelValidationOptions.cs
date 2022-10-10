using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelValidationOptions
    {
        internal static readonly ModelValidationOptions Default = new ModelValidationOptions(isDefault: true);
        private ModelValidationFlags _flags;

        public ModelValidationOptions()
        {
            _flags = ModelValidationFlags.All;
        }

        private ModelValidationOptions(bool isDefault)
        {
            _flags = ModelValidationFlags.All | ModelValidationFlags.IsDefault;
        }

        public bool ValidateReadOnly
        {
            get => _flags.HasFlag(ModelValidationFlags.ReadOnly);
            set
            {
                if (!_flags.HasFlag(ModelValidationFlags.IsDefault)) _flags = WithFlag(ModelValidationFlags.ReadOnly, value);
            }
        }

        public bool ValidateNullable
        {
            get => _flags.HasFlag(ModelValidationFlags.Nullable);
            set
            {
                if (!_flags.HasFlag(ModelValidationFlags.IsDefault)) _flags = WithFlag(ModelValidationFlags.Nullable, value);
            }
        }

        public bool FullPropertyModificationStackInExceptions
        {
            get => _flags.HasFlag(ModelValidationFlags.FullPropertyStack);
            set
            {
                if (!_flags.HasFlag(ModelValidationFlags.IsDefault)) _flags = WithFlag(ModelValidationFlags.FullPropertyStack, value);
            }
        }

        private ModelValidationFlags WithFlag(ModelValidationFlags flag, bool enable)
        {
            if (enable)
            {
                if (_flags.HasFlag(flag)) return _flags;
                else return _flags | flag;
            }
            else
            {
                if (!_flags.HasFlag(flag)) return _flags;
                else return _flags & ~flag;
            }
        }
    }
}
