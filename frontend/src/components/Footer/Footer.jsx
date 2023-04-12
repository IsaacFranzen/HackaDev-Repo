import React from "react";
import { Container, FooterStyle } from "./Footer-styles";

const Footer = () => {
  return (
    <Container>
      <FooterStyle>
        Para saber mais, <a href="/contato"> fale conosco aqui!</a>
      </FooterStyle>
    </Container>
  );
};

export default Footer;
