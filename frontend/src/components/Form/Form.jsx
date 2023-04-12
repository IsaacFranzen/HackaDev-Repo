/* eslint-disable no-unused-vars */
import React, { useState } from "react";
import PrimeiraAba from "../AllTabs/PrimeiraAba";
import SegundaAba from "../AllTabs/SegundaAba";
import {
  DataFormBasicas,
  DataFormPessoais,
  DataFormProfissao,
} from "../../utils/DataForm";
import { DivButtonStyles, DivNav, StyleButton, TabsDiv } from "./Form-styles";
import Carteira from "../../assets/svg/carteira-de-identidade.svg";
import DadosPessoais from "../../assets/svg/dados-pessoais.svg";
import DadosProfissionais from "../../assets/svg/curriculo.svg";
import TerceiraAba from "../AllTabs/TerceiraAba";

function Formulario() {
  const [page, setPage] = useState(0);
  const [formData, setFormData] = useState(
    DataFormBasicas,
    DataFormPessoais,
    DataFormProfissao
  );

  const FormTitles = [
    "Informacoes Basicas",
    "Dados Pessoais",
    "Dados Profissionais",
  ];
  const PageDisplay = () => {
    if (page === 0) {
      return <PrimeiraAba formData={formData} setFormData={setFormData} />;
    } else if (page === 1) {
      return <SegundaAba formData={formData} setFormData={setFormData} />;
    } else {
      return <TerceiraAba formData={formData} setFormData={setFormData} />;
    }
  };

  return (
    <TabsDiv>
      <div>
        <DivNav>
          <li className={page === 0 ? "active" : ""}>
            Informações Básicas
            <img
              src={Carteira}
              style={{
                width: 70,
                height: 70,
              }}
            />
          </li>

          <li className={page === 1 ? "active" : ""}>
            Dados Pessoais
            <img
              src={DadosPessoais}
              style={{
                width: 70,
                height: 70,
              }}
            />
          </li>
          <li className={page === 2 ? "active" : ""}>
            Dados Profíssionais
            <img
              src={DadosProfissionais}
              style={{
                width: 70,
                height: 70,
              }}
            />
          </li>
        </DivNav>
      </div>
      <div>{PageDisplay()}</div>
      <DivButtonStyles
        style={{ width: "100%", justifyContent: "center", display: "flex" }}
      >
        <StyleButton
          disabled={page == 0}
          type="submit"
          onClick={() => {
            setPage((currPage) => currPage - 1);
          }}
        >
          Anterior
        </StyleButton>
        <StyleButton
          onClick={() => {
            if (page === FormTitles.length - 1) {
              alert("Dados Enviados");
              console.log(formData);
            } else {
              setPage((currPage) => currPage + 1);
            }
          }}
        >
          {page === FormTitles.length - 1 ? "Enviar" : "Proximo"}
        </StyleButton>
      </DivButtonStyles>
    </TabsDiv>
  );
}

export default Formulario;
