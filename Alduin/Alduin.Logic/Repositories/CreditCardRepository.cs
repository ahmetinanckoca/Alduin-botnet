﻿using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class CreditCardRepository : RepositoryBase<CreditCardEntity, CreditCardDTO>, ICreditCardRepository
    {
        public CreditCardRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }
    }
}
