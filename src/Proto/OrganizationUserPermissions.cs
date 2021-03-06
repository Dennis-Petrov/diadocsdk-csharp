﻿using System.Runtime.InteropServices;

namespace Diadoc.Api.Proto
{
	[ComVisible(true)]
	[Guid("092B7B80-E117-4B90-BC57-C08AEAD99842")]
	public interface IOrganizationUserPermissions
	{
		string UserDepartmentId { get; }
		bool IsAdministrator { get; }
		Com.DocumentAccessLevel DocumentAccessLevelValue { get; }
		bool CanSignDocuments { get; }
		bool CanAddResolutions { get; }
		bool CanRequestResolutions { get; }
	}

	[ComVisible(true)]
	[Guid("783B622C-88B1-4B88-A855-370EB9848DB0")]
	[ClassInterface(ClassInterfaceType.None)]
	[ComDefaultInterface(typeof (IOrganizationUserPermissions))]
	public partial class OrganizationUserPermissions: SafeComObject, IOrganizationUserPermissions
	{
		public override string ToString()
		{
			return string.Format("UserDepartmentId: {0}, IsAdministrator: {1}, DocumentAccessLevel: {2}, CanSignDocuments: {3}, CanAddResolutions: {4}, CanRequestResolutions: {5}",
				UserDepartmentId, IsAdministrator, DocumentAccessLevel, CanSignDocuments, CanAddResolutions, CanRequestResolutions);
		}

		public Com.DocumentAccessLevel DocumentAccessLevelValue
		{
			get { return (Com.DocumentAccessLevel)((int)DocumentAccessLevel); }
		}
	}
}
