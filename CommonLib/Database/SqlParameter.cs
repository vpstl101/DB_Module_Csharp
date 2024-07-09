﻿namespace CommonLib.Database
{
    public class SqlParameter
    {
        private readonly string parameterName;
        private readonly object value;

        //SqlParameter 생성자
        public SqlParameter(string parameterName, object value)
        {
            this.parameterName = parameterName;
            this.value = value;
        }

        public string ParameterName => parameterName;
        public object Value => value;

    }
}