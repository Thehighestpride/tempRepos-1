<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chatRoom.aspx.cs" Inherits="chattingProgram.chattingroom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>채팅방</title>
	<link href="../css Files/chatRoom.css" rel="stylesheet" />
</head>
<body>
	<form id="form1" runat="server" >
			<div class="room">
				<div class="header">
					<img src="https://m.theflowerseason.com/file_data/ksj931229/2020/06/10/0a980de2453e19a58e04d3a85df62028.jpg" class="profile-img" />
					<h5 class="profile-name">안지영</h5>
				</div>
				<ul runat="server" class="chat-space" id="chat_space">
				</ul>
				<div class="entry-space">
					<textarea runat="server" class="txtInput" id="txtInput"></textarea>
					<div class="entry-ui">
						<asp:Button ID="btnEnter" runat="server" Text="전송" CssClass="btnenter" OnClick="btnEnter_Click" />
					</div>
				</div>
			</div>
	</form>
</body>
</html>
