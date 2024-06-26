﻿using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteLookupDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDpo => noteDpo.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(noteDpo => noteDpo.Title,
                    opt => opt.MapFrom(note => note.Title));
        }
    }
}
