import React, { useState } from "react";
import { Collapse, Card, CardBody, CardHeader } from "reactstrap";
import '../styles/AccordionFaq.css'

const AccordionFaq = ({ faqs }) => {
    const [isOpenList, setIsOpenList] = useState(Array(faqs.length).fill(false));

    const toggleAccordion = (index) => {
        const newIsOpenList = [...isOpenList];
        newIsOpenList[index] = !newIsOpenList[index];
        setIsOpenList(newIsOpenList);
    };

    return (
        <div className="pb-4 accordion-spacing">
            <h1 className="text-center mb-4 pb-4">Často kladené otázky</h1>
            <div className="accordion">
                {faqs.map((faq, index) => (
                    <Card key={index}>
                        <CardHeader
                            className="accordion-header"
                            onClick={() => toggleAccordion(index)}
                        >
                            {faq.question}
                        </CardHeader>
                        <Collapse isOpen={isOpenList[index]}>
                            <CardBody className="accordion-body">{faq.answer}</CardBody>
                        </Collapse>
                    </Card>
                ))}
            </div>
        </div>
    );
};

export default AccordionFaq;
