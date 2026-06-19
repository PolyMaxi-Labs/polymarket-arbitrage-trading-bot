public IActionResult GenerateSchema(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return BadRequest("Input cannot be empty.");
    }
    // Logic to generate schema
}