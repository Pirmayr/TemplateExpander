<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="xml" version="1.0" indent="yes" standalone="yes"/>
  <xsl:template match="/">
    <documentation>
      <xsl:for-each select="doxygenindex/compound">
        <xsl:for-each select="document(concat(@refid, '.xml'))/doxygen/compounddef">
          <compound name="{./compoundname}" kind="{@kind}">
            <xsl:for-each select="./sectiondef">
              <section kind="{@kind}">
                <xsl:for-each select="./memberdef">
                  <member name="{./name}" kind="{@kind}" type="{./type}">
                    <xsl:if test="./briefdescription/child::* != ''">
                      <brief>
                        <xsl:copy-of select="./briefdescription/child::*"/>
                      </brief>
                    </xsl:if>
                    <xsl:if test="./param">
                      <parameters>
                        <xsl:for-each select="./param">
                          <parameter name="{./declname}" type="{./type}">
                            <xsl:for-each select="../detaileddescription/para/parameterlist/parameteritem[./parameternamelist/parametername=current()/declname]">
                              <brief>
                                <xsl:copy-of select="./parameterdescription/child::*"/>
                              </brief>
                            </xsl:for-each>
                          </parameter>
                        </xsl:for-each>
                      </parameters>
                    </xsl:if>
                    <xsl:for-each select="./detaileddescription">
                      <xsl:for-each select="./para">
                        <xsl:choose>
                          <xsl:when test="./parameterlist or ./simplesect">
                            <xsl:if test="./simplesect">
                              <returns>
                                <xsl:copy-of select="./simplesect/child::*"/>
                              </returns>
                            </xsl:if>
                          </xsl:when>
                          <xsl:otherwise>
                            <remarks>
                              <xsl:copy-of select="."/>
                            </remarks>
                          </xsl:otherwise>
                        </xsl:choose>
                      </xsl:for-each>
                    </xsl:for-each>
                  </member>
                </xsl:for-each>
              </section>
            </xsl:for-each>
            <xsl:if test="./detaileddescription != ''">
              <xsl:for-each select="./detaileddescription">
                <description>
                  <xsl:for-each select="./para">
                    <xsl:choose>
                      <xsl:when test="./heading">
                        <xsl:copy-of select="./heading"/>
                      </xsl:when>
                      <xsl:otherwise>
                        <para>
                          <xsl:value-of select="."/>
                        </para>
                      </xsl:otherwise>
                    </xsl:choose>
                  </xsl:for-each>
                </description>
              </xsl:for-each>
            </xsl:if>
          </compound>
        </xsl:for-each>
      </xsl:for-each>
    </documentation>
  </xsl:template>
</xsl:stylesheet>