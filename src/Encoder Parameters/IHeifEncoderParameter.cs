﻿/*
 * .NET bindings for libheif.
 * Copyright (c) 2020, 2021, 2022 Nicholas Hayes
 *
 * Portions Copyright (c) 2017 struktur AG, Dirk Farin <farin@struktur.de>
 *
 * This file is part of libheif-sharp.
 *
 * libheif-sharp is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as
 * published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version.
 *
 * libheif-sharp is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with libheif-sharp.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace LibHeifSharp
{
    /// <summary>
    /// The interface that all LibHeif encoder parameters implement
    /// </summary>
    public interface IHeifEncoderParameter
    {
        /// <summary>
        /// Gets the parameter name.
        /// </summary>
        /// <value>
        /// The parameter name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        /// <value>
        /// The type of the parameter.
        /// </value>
        HeifEncoderParameterType ParameterType { get; }
    }
}