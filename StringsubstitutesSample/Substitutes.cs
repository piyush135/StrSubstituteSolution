using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsubstitutesSample 
{
    public class Substitutes 
    {
        public static string DEFAULT_PREFIX = "%";

        public static string DEFAULT_SUFFIX = "%";    
        
        public Substitutes(String prefix, String suffix)
        {
            DEFAULT_PREFIX = !string.IsNullOrEmpty(prefix) ? prefix : DEFAULT_PREFIX;
            DEFAULT_SUFFIX = !string.IsNullOrEmpty(suffix) ? suffix : DEFAULT_SUFFIX;            
        }

        public String Replace(string inputSource, Dictionary<string, int> valueMap)
        {
            if(string.IsNullOrEmpty(inputSource)) throw new ValueNotFoundException(ErrorMessage.InputValueMissing);
            if (valueMap == null) throw new ValueNotFoundException(ErrorMessage.ValueMapMissing);            
            return ReplaceString(inputSource, valueMap);
        }

        public Regex GetRegexPattern()
        {
           return new Regex(string.Format(@"\{0}(\w+)\{1}", DEFAULT_PREFIX, DEFAULT_SUFFIX), RegexOptions.Compiled);
        }

        public string ReplaceString(string source, Dictionary<string, int> valueMap)
        {
            var customRegexToReplaceStr = GetRegexPattern();
            if (customRegexToReplaceStr != null)
            {
                return customRegexToReplaceStr.Replace(source, match =>
                {
                    if (valueMap.ContainsKey(match.Groups[1].Value))
                        return valueMap[match.Groups[1].Value].ToString();
                    return match.Value;
                });
            }
            return source;
        }
    }
}
