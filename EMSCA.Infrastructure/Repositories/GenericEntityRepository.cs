
using EMSCA.Application.Repositories;
using EMSCA.Application.Repository;
using EMSCA.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMSCA.Infrastructure.Repositories
{
	public class GenericEntityRepository<TEntity> : EntityRepositoryBase<DbContext, TEntity> where TEntity : BaseEntity, new()
	{
		public GenericEntityRepository() : base( null)
		{ }
	}
}
