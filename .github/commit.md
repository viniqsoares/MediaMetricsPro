[type](optional scope): [subject]
[optional body]
[optional footer]

# A properly formed Git commit subject line should always be able to complete
# the following sentence:
#     * If applied, this commit <will your subject line here>
#
# ** Example:
# [type](optional scope): [subject]
#
# [optional body]
#
# [optional footer]

# ** Type
# Must be one of the following:
# * build - Build related changes
# * chore - Build process or auxiliary tool changes
# * docs - Documentation only changes
# * feat - A new feature
# * fix - A bug fix
# * perf - A code change that improves performance
# * refactor - A code change that neither fixes a bug or adds a feature
# * revert - Reverting things
# * style - Markup, white-space, formatting, missing semi-colons...
# * test - Adding missing tests

# ** Subject
# The subject contains a succint description of the change:
# * Use the imperative, present tense: "change" not "changed" nor "changes"
# * No dot (.) at the end.

# ** Scope
# A scope may be provided to a commit’s type, to provide additional contextual information
# and is contained within parenthesis, e.g., feat(parser): add ability to parse arrays.

# ** Body
# Just as in the subject, use the imperative, present tense: "change" not "changed" nor "changes".
# The body should include the motivation for the change and contrast this with previous behavior.

# ** Rules
# The 7 rules of a great commit message
#    1. Separate subject from body with a blank line
#    2. Limit the subject line to 50 characters
#    3. Summary in present tense. Not capitalized
#    4. Do not end the subject line with a period
#    5. Use the imperative mood in the subject line
#    6. Wrap the body at 72 characters
#    7. Use the body to explain what and why vs. how
