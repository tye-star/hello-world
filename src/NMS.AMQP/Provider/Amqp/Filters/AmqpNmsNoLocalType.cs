/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Amqp.Types;

namespace Apache.NMS.AMQP.Provider.Amqp.Filters
{
    public class AmqpNmsNoLocalType : DescribedValue
    {
        private const ulong DESCRIPTOR = 0x0000468C00000003L;
        private const string DESCRIBED = "NoLocalFilter{}";
        
        public static readonly AmqpNmsNoLocalType NO_LOCAL = new AmqpNmsNoLocalType();

        private AmqpNmsNoLocalType() : base(DESCRIPTOR, DESCRIBED)
        {
        }

        public override string ToString() => $"AmqpNmsSelectorType{{ {this.Value} }}";
    }
}