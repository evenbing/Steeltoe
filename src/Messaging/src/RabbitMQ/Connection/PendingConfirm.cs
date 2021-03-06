﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Steeltoe.Messaging.Rabbit.Connection
{
    public class PendingConfirm
    {
        public PendingConfirm(CorrelationData correlationData, long timestamp)
        {
            CorrelationInfo = correlationData;
            Timestamp = timestamp;
        }

        public CorrelationData CorrelationInfo { get; }

        public long Timestamp { get; }

        public string Cause { get; set; }

        public override string ToString()
        {
            return "PendingConfirm [correlationInfo=" + CorrelationInfo + (Cause == null ? string.Empty : " cause=" + Cause) + "]";
        }
    }
}
