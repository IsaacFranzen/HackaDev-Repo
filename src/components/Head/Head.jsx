import React from "react";
import { Button, Container, DivImage, Main, Sections } from "./Head-styles";
import { ReactComponent as PeapleMoney } from "../../utils/svg/people-with-money1.svg";

const Head = () => {
  return (
    <Container>
      <Main>
        <Sections>
          <h1>
            Um <span> Banco Online </span>feito para você!
          </h1>
          <p>
            Nosso sistema é extremamente
            <span> completo</span>, permitindo que você gerencie suas finanças
            de maneira
            <span> fácil, rápida e segura.</span>
          </p>
          <Button type="button">ABRA SUA CONTA JÁ</Button>
        </Sections>
        <DivImage>
          <PeapleMoney />
        </DivImage>
      </Main>
    </Container>
  );
};

export default Head;
