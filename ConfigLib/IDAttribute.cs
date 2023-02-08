using System;

namespace ConfigLib
{
    /// <summary>
    /// 지정된 속성 또는 필드가 <see cref="ConfigBase"/>에 의해 저장/불러오기 될 수 있습니다.
    /// </summary>
    [AttributeUsage( AttributeTargets.Property )]
    public class IDAttribute : Attribute
    {
        public string ID => _id;
        private string _id = string.Empty;

        public bool IsDefault => _isDefault;
        private bool _isDefault = false;

        /// <summary>
        /// 속성 또는 필드가 저장/불러오기 될 때 사용할 ID를 직접 지정하지 않고 이름을 사용합니다.
        /// </summary>
        public IDAttribute() => _isDefault = true;
        /// <summary>
        /// 속성 또는 필드가 저장/불러오기 될 때 사용할 ID를 직접 지정합니다.
        /// </summary>
        /// <param name="id"></param>
        public IDAttribute( string id ) => _id = id;
    }
}
