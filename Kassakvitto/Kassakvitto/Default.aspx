<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kassakvitto.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="~/Scripts/jquery-1.8.2.min.js"></script>
    <script src="/Scripts/app.js"></script>
    <link rel="stylesheet" href="~/Content/app.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="CalcDiscount">
        <div class="wrapper">
            <h1>Kassakvitto</h1>
            <p>
                <asp:Label ID="TotalPrice" runat="server" Text="Total köpesumma:"></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="TotalPriceBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredPriceValidator"
                    runat="server"
                    ControlToValidate="TotalPriceBox"
                    ErrorMessage="Ange en total köpesumma"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator
                    ID="ComparePriceValidator"
                    runat="server"
                    ControlToValidate="TotalPriceBox"
                    Type="Double"
                    Operator="GreaterThan"
                    ValueToCompare="0"
                    ErrorMessage="Ange en köpesumma större än 0"
                    Display="Dynamic">
                </asp:CompareValidator>
            </p>
            <p>
                <asp:Button ID="CalcDiscount" runat="server" Text="Beräkna rabatt" OnClick="CalcDiscount_Click" />
            </p>

            <div id="receipt" runat="server">
                <p>
                    <asp:Label ID="LabelSubtotal" runat="server" Text=""></asp:Label>
                </p>

                <p>
                    <asp:Label ID="LabelDiscount" runat="server" Text=""></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelMoneyOff" runat="server" Text=""></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelTotal" runat="server" Text=""></asp:Label>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
