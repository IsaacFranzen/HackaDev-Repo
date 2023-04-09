import React from 'react'
import Modal from './../Modal/Modal';
import { useForm } from 'react-hook-form';
import { yupResolver } from '@hookform/resolvers/yup'
import * as yup from 'yup';

import { Button, InputField } from './MakeTransference-styles';

export default function MakeTransference({ isOpen, setModalClose }) {

  const schema = yup.object({
    destinataryKey: yup
      .string()
      .required("O preenchimento da chave do destinatário é obrigatório.")
      .min(3, "Você deve fornecer ao menos 3 caractéres."),
    amount: yup
      .string()
      .required("O preenchimento do valor a ser transferido é obrigatório."),
  });

  const { 
    handleSubmit: onSubmit, 
    formState: { errors },
    register
  } = useForm({resolver: yupResolver(schema)});

  const handleSubmit = (data) => {
    console.log(data);
    setModalClose();
  }


  return (
    <Modal isOpen={isOpen} setModalClose={setModalClose}>
      <h2>Transferência</h2>
      <form onSubmit={onSubmit(handleSubmit)}>
        <InputField>
          <span className="icon">
            <ion-icon name="person"></ion-icon>
          </span>
          <input type="text" id="destinataryKey" 
            { ...register("destinataryKey") } 
          />
          <span className="validationError">
            {errors?.destinataryKey?.message}
          </span>
          <label>Chave do Destinatário</label>
        </InputField>
        <InputField>
          <span className="icon">
              <ion-icon name="cash-outline"></ion-icon></span>
          <input type="number" step='0.01'
            id="amount"  { ...register("amount")}
          />
          <label>Valor</label>
          <span className="validationError">
            {errors?.amount?.message}
          </span>
        </InputField>
        <Button>Transferir</Button>
      </form>
    </Modal>
  )
}
