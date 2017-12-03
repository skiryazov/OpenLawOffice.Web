﻿// -----------------------------------------------------------------------
// <copyright file="ActivityStatusReasonViewModel.cs" company="Nodine Legal, LLC">
// Licensed to Nodine Legal, LLC under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  Nodine Legal, LLC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>
// -----------------------------------------------------------------------

namespace OpenLawOffice.Web.ViewModels.Activities
{
    using Common.Models;
    using AutoMapper;

    [MapMe]
    public class ActivityStatusReasonViewModel : ViewModelBase
    {
        public int? Id { get; set; }
        public string Primary { get; set; }
        public string Secondary { get; set; }
        public int? Order { get; set; }

        public void BuildMappings()
        {
            Mapper.CreateMap<Common.Models.Activities.ActivityStatusReason, ActivityStatusReasonViewModel>()
                .ForMember(dst => dst.IsStub, opt => opt.UseValue(false))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Primary, opt => opt.MapFrom(src => src.Primary))
                .ForMember(dst => dst.Secondary, opt => opt.MapFrom(src => src.Secondary))
                .ForMember(dst => dst.Order, opt => opt.MapFrom(src => src.Order));

            Mapper.CreateMap<ActivityStatusReasonViewModel, Common.Models.Activities.ActivityStatusReason>()
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dst => dst.Primary, opt => opt.MapFrom(src => src.Primary))
                .ForMember(dst => dst.Secondary, opt => opt.MapFrom(src => src.Secondary))
                .ForMember(dst => dst.Order, opt => opt.MapFrom(src => src.Order));
        }
    }
}
