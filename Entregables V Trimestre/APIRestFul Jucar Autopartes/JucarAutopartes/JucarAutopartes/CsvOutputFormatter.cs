using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Shared.DataTransferObjects.Products;
using System.Text;

namespace JucarAutopartes
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));

            SupportedEncodings.Add(Encoding.UTF8);

            SupportedEncodings.Add(Encoding.Unicode);
        }

        protected override bool CanWriteType(Type? type)
        {
            if (typeof(CategoryDto).IsAssignableFrom(type) || typeof(IEnumerable<CategoryDto>).IsAssignableFrom(type))
            {

                return base.CanWriteType(type);

            }

            //if (typeof(SubcategoryDto).IsAssignableFrom(type) || typeof(IEnumerable<SubcategoryDto>).IsAssignableFrom(type))
            //{

            //    return base.CanWriteType(type);

            //}

            //if (typeof(AutopartDto).IsAssignableFrom(type) || typeof(IEnumerable<AutopartDto>).IsAssignableFrom(type))
            //{

            //    return base.CanWriteType(type);

            //}

            return false;


        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;

            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<CategoryDto>)
            {
                foreach (var category in (IEnumerable<CategoryDto>)context.Object)
                {
                    FormatCsv(buffer, category);
                }
            }
            else
            {
                FormatCsv(buffer, (CategoryDto)context.Object);
            }

            await response.WriteAsync(buffer.ToString());
        }

        private static void FormatCsv(StringBuilder buffer, CategoryDto category)
        {
            buffer.AppendLine($"{category.CategoryId},\" {category.Name},\"{category.State},\"{category.CreationDate},\"{category.ModificationDate}");
        }
    }
}
