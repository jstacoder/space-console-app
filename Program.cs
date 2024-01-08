using JetBrains.Space.Client;
using JetBrains.Space.Common;

// url of space instance
var url = new Uri("https://tzp-software.jetbrains.space");
// access token 
// read from .token file
var token = ''
var authTokens = new AuthenticationTokens(token);
var connection = new BearerTokenConnection(url, authTokens);

var chatClient = new ChatClient(connection);
await chatClient.Messages.SendMessageAsync(
        recipient: MessageRecipient.Member(ProfileIdentifier.Username("jstacoder")),
        content: new ChatMessageText("Wazzzzz aaappppppp"));
